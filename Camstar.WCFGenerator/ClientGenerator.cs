// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.ClientGenerator
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Camstar.WCF.Generator
{
  internal class ClientGenerator : ServiceAssemblyGeneratorBase
  {
    private string _ClientNamespace;
    private const string onPrefix = "On";
    private const string onBeforeCallMethodName = "OnBeforeCall";
    private const string onAfterCallMethodName = "OnAfterCall";
    private const string IsSuccessPropertyName = "IsSuccess";

    public ClientGenerator(
      ModuleBuilder moduleBuilder,
      DCTypeStore dCTypeStore,
      string nameSpace,
      string clientNamespace)
      : this(moduleBuilder, dCTypeStore, nameSpace, clientNamespace, false)
    {
    }

    public ClientGenerator(
      ModuleBuilder moduleBuilder,
      DCTypeStore dCTypeStore,
      string nameSpace,
      string clientNamespace,
      bool isSilverlight)
      : base(nameSpace, moduleBuilder, dCTypeStore)
    {
      this._ClientNamespace = clientNamespace;
      this._IsSilverlight = isSilverlight;
    }

    public override void AddService(ServiceBase service)
    {
      this.AddServiceInterface(service);
      if (this._IsSilverlight)
        return;
      Type type1 = this.dCTypeStore.GetDCBuilderType("WCFService").Type;
      ServiceBase wcfServiceBaseType = service.ParentWCFServiceBaseType;
      bool flag1 = false;
      if (wcfServiceBaseType != null)
        flag1 = true;
      if (flag1)
        type1 = this.dCTypeStore.GetDCBuilderType(wcfServiceBaseType.Name + "Base").Type;
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType("I" + service.Name + "Service");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(service.Name);
      DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Request");
      DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Result");
      DCBuilderType dcBuilderType5 = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      DCBuilderType dcBuilderType6 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Parameters");
      if (service.ExposedState == ExposedServiceStateType.Exposed || service.ExposedState == ExposedServiceStateType.BaseAndExposed)
      {
        TypeBuilder typeBuilder = this.moduleBuilder.DefineType(this.nameSpacePrefix + service.Name + "Service", TypeAttributes.Public, type1);
        this.ImplementConstructor(typeBuilder, type1);
        List<MethodInfo> methods = new List<MethodInfo>();
        foreach (IMethod method in service.GetMethods())
        {
          if (method.ExposedState == ExposedMethodStateType.Exposed || method.ExposedState == ExposedMethodStateType.BaseAndExposed)
          {
            MethodInfo mainMethod = this.AddMainMethod(typeBuilder, method, dcBuilderType5, dcBuilderType2, dcBuilderType3, dcBuilderType4, dcBuilderType6, dcBuilderType1, (IService) service, type1, (MethodInfo) null, false);
            this.AddOverloadMethodWithoutParams(typeBuilder, method, dcBuilderType1, dcBuilderType5, dcBuilderType4, service.Name, mainMethod, false);
            this.AddOverloadMethodWithOneParam(typeBuilder, method, dcBuilderType1, dcBuilderType5, dcBuilderType4, dcBuilderType2, service.Name, mainMethod, false);
            this.AddOverloadMethodWithThreeParams(typeBuilder, method, dcBuilderType1, dcBuilderType5, dcBuilderType2, dcBuilderType3, dcBuilderType4, service.Name, mainMethod, false);
            methods.Add(mainMethod);
          }
        }
        if (flag1)
        {
          foreach (MethodInfo method in type1.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic))
          {
            if (!method.IsFinal)
              this.AddOverrideMethod(typeBuilder, method.Name, dcBuilderType5, dcBuilderType2, dcBuilderType3, dcBuilderType4, dcBuilderType6, type1, methods, service);
          }
        }
        this.AddCommitTransactionMethod((IService) service, typeBuilder, dcBuilderType1, dcBuilderType3, dcBuilderType4, type1);
        this.AddGetEnvironmentMethod(typeBuilder, dcBuilderType2, dcBuilderType1, dcBuilderType3, dcBuilderType4, type1);
        this.AddExecuteTransactionMethod((IService) service, typeBuilder, dcBuilderType2, dcBuilderType1, dcBuilderType3, dcBuilderType4, type1);
        this.AddAddDataTransactionMethod(service, typeBuilder, dcBuilderType2, dcBuilderType1, type1);
        typeBuilder.CreateType();
      }
      if (service.ExposedState != ExposedServiceStateType.Base && service.ExposedState != ExposedServiceStateType.BaseAndExposed)
        return;
      DCBuilderType dcBuilderType7 = this.dCTypeStore.GetDCBuilderType("DCObject");
      DCBuilderType dcBuilderType8 = this.dCTypeStore.GetDCBuilderType("Request");
      DCBuilderType dcBuilderType9 = this.dCTypeStore.GetDCBuilderType("Result");
      DCBuilderType dcBuilderType10 = this.dCTypeStore.GetDCBuilderType("Parameters");
      DCBuilderType dcBuilderType11 = this.dCTypeStore.GetDCBuilderType("I" + service.Name + "Base");
      TypeBuilder typeBuilder1 = this.moduleBuilder.DefineType(this.nameSpacePrefix + service.Name + "Base", TypeAttributes.Public, type1, new Type[1]
      {
        dcBuilderType11.Type
      });
      DCBuilderType dcBuilderType12 = this.dCTypeStore.GetDCBuilderType("I" + type1.Name) ?? this.dCTypeStore.GetDCBuilderType("IWCFService");
      DCBuilderType dcBuilderType13 = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      List<MethodInfo> methodInfoList = new List<MethodInfo>();
      methodInfoList.AddRange((IEnumerable<MethodInfo>) dcBuilderType12.Type.GetMethods(BindingFlags.Instance | BindingFlags.Public));
      foreach (Type type2 in dcBuilderType12.Type.GetInterfaces())
        methodInfoList.AddRange((IEnumerable<MethodInfo>) type2.GetMethods(BindingFlags.Instance | BindingFlags.Public));
      foreach (IMethod method in service.GetMethods())
      {
        if (method.IsInherited)
        {
          bool flag2 = false;
          foreach (MethodInfo methodInfo in methodInfoList)
          {
            if (method.Name == methodInfo.Name)
              flag2 = true;
          }
          if (flag2)
            continue;
        }
        if (method.ExposedState == ExposedMethodStateType.Base || method.ExposedState == ExposedMethodStateType.BaseAndExposed)
        {
          MethodInfo virtualMethod = this.AddVirtualMethod(typeBuilder1, method, dcBuilderType13, dcBuilderType7, dcBuilderType8, dcBuilderType9, dcBuilderType10, service);
          MethodInfo mainMethod = this.AddMainMethod(typeBuilder1, method, dcBuilderType13, dcBuilderType7, dcBuilderType8, dcBuilderType9, dcBuilderType10, dcBuilderType11, (IService) service, type1, virtualMethod, true);
          this.AddOverloadMethodWithoutParams(typeBuilder1, method, dcBuilderType11, dcBuilderType13, dcBuilderType9, service.Name, mainMethod, true);
          this.AddOverloadMethodWithOneParam(typeBuilder1, method, dcBuilderType11, dcBuilderType13, dcBuilderType9, dcBuilderType7, service.Name, mainMethod, true);
          this.AddOverloadMethodWithThreeParams(typeBuilder1, method, dcBuilderType11, dcBuilderType13, dcBuilderType7, dcBuilderType8, dcBuilderType9, service.Name, mainMethod, true);
        }
      }
      this.dCTypeStore.Add(service.Name + "Base", typeBuilder1.CreateType(), typeBuilder1);
    }

    private void AddOverrideMethod(
      TypeBuilder typeBuilder,
      string methodName,
      DCBuilderType statusDCBuilderType,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      DCBuilderType parametersDCBuilderType,
      Type baseType,
      List<MethodInfo> methods,
      ServiceBase service)
    {
      MethodInfo meth = (MethodInfo) null;
      foreach (MethodInfo method in methods)
      {
        if (method.Name == methodName.Substring(2))
          meth = method;
      }
      if (meth == (MethodInfo) null)
        return;
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType("DCObject");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType("Request");
      DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType("Result");
      DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType("Parameters");
      Type[] parameterTypes = new Type[4]
      {
        dcBuilderType1.Type,
        dcBuilderType4.Type,
        dcBuilderType2.Type,
        dcBuilderType3.Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod(methodName, MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, statusDCBuilderType.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
      methodBuilder.DefineParameter(2, ParameterAttributes.None, "parameters");
      methodBuilder.DefineParameter(3, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(4, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      LocalBuilder local = ilGenerator.DeclareLocal(resultDCBuilderType.Type);
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.DeclareLocal(typeof (Exception));
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_S, 4);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.BeginExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Castclass, cdoDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Castclass, parametersDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Castclass, requestDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldloca_S, local);
      ilGenerator.Emit(OpCodes.Call, meth);
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldarg_S, 4);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.BeginCatchBlock(typeof (Exception));
      ilGenerator.Emit(OpCodes.Stloc_2);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_2);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc_3);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private MethodInfo AddVirtualMethod(
      TypeBuilder typeBuilder,
      IMethod method,
      DCBuilderType statusDCBuilderType,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      DCBuilderType parametersDCBuilderType,
      ServiceBase service)
    {
      Type type = this.dCTypeStore.GetDCBuilderType("WCFService").Type;
      Type[] parameterTypes = new Type[4]
      {
        cdoDCBuilderType.Type,
        parametersDCBuilderType.Type,
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("On" + method.Name, MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, statusDCBuilderType.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
      methodBuilder.DefineParameter(2, ParameterAttributes.None, "parameters");
      methodBuilder.DefineParameter(3, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(4, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_S, 4);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldstr, method.Name);
      ilGenerator.Emit(OpCodes.Call, type.GetMethod("NoMethod", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ret);
      return (MethodInfo) methodBuilder;
    }

    private void AddOverloadMethodWithoutParams(
      TypeBuilder typeBuilder,
      IMethod method,
      DCBuilderType dCBuilderType,
      DCBuilderType statusDCBuilderType,
      DCBuilderType resultDCBuilderType,
      string serviceName,
      MethodInfo mainMethod,
      bool isBaseClient)
    {
      Type[] typeArray = new Type[0];
      MethodBuilder methodBuilder;
      if (!isBaseClient)
      {
        methodBuilder = typeBuilder.DefineMethod(method.Name, MethodAttributes.Public | MethodAttributes.HideBySig, statusDCBuilderType.Type, typeArray);
      }
      else
      {
        string name = this.nameSpacePrefix + "I" + serviceName + "Base." + method.Name;
        methodBuilder = typeBuilder.DefineMethod(name, MethodAttributes.Private | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, statusDCBuilderType.Type, typeArray);
        typeBuilder.DefineMethodOverride((MethodInfo) methodBuilder, dCBuilderType.Type.GetMethod(method.Name, typeArray));
      }
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(resultDCBuilderType.Type);
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldloca_S, 0);
      ilGenerator.Emit(OpCodes.Call, mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_1);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddOverloadMethodWithOneParam(
      TypeBuilder typeBuilder,
      IMethod method,
      DCBuilderType dCBuilderType,
      DCBuilderType statusDCBuilderType,
      DCBuilderType resultDCBuilderType,
      DCBuilderType cdoDCBuilderType,
      string serviceName,
      MethodInfo mainMethod,
      bool isBaseClient)
    {
      Type[] typeArray = new Type[1]
      {
        cdoDCBuilderType.Type
      };
      MethodBuilder methodBuilder;
      if (!isBaseClient)
      {
        methodBuilder = typeBuilder.DefineMethod(method.Name, MethodAttributes.Public | MethodAttributes.HideBySig, statusDCBuilderType.Type, typeArray);
      }
      else
      {
        string name = this.nameSpacePrefix + "I" + serviceName + "Base." + method.Name;
        methodBuilder = typeBuilder.DefineMethod(name, MethodAttributes.Private | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, statusDCBuilderType.Type, typeArray);
        typeBuilder.DefineMethodOverride((MethodInfo) methodBuilder, dCBuilderType.Type.GetMethod(method.Name, typeArray));
      }
      methodBuilder.DefineParameter(1, ParameterAttributes.None, serviceName.Substring(0, 1).ToLower() + serviceName.Substring(1));
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(resultDCBuilderType.Type);
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldloca_S, 0);
      ilGenerator.Emit(OpCodes.Call, mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_1);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddOverloadMethodWithThreeParams(
      TypeBuilder typeBuilder,
      IMethod method,
      DCBuilderType dCBuilderType,
      DCBuilderType statusDCBuilderType,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      string serviceName,
      MethodInfo mainMethod,
      bool isBaseClient)
    {
      Type[] typeArray = new Type[3]
      {
        cdoDCBuilderType.Type,
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      };
      MethodBuilder methodBuilder;
      if (!isBaseClient)
      {
        methodBuilder = typeBuilder.DefineMethod(method.Name, MethodAttributes.Public | MethodAttributes.HideBySig, statusDCBuilderType.Type, typeArray);
      }
      else
      {
        string name = this.nameSpacePrefix + "I" + serviceName + "Base." + method.Name;
        methodBuilder = typeBuilder.DefineMethod(name, MethodAttributes.Private | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, statusDCBuilderType.Type, typeArray);
        typeBuilder.DefineMethodOverride((MethodInfo) methodBuilder, dCBuilderType.Type.GetMethod(method.Name, typeArray));
      }
      methodBuilder.DefineParameter(1, ParameterAttributes.None, serviceName.Substring(0, 1).ToLower() + serviceName.Substring(1));
      methodBuilder.DefineParameter(2, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(3, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Call, mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_0);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private MethodInfo AddMainMethod(
      TypeBuilder typeBuilder,
      IMethod method,
      DCBuilderType statusDCBuilderType,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      DCBuilderType parametersDCBuilderType,
      DCBuilderType dCBuilderType,
      IService service,
      Type baseType,
      MethodInfo virtualMethod,
      bool isBaseClient)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType(service.Name + "Method");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(service.Name + "Methods");
      Type[] typeArray = new Type[4]
      {
        cdoDCBuilderType.Type,
        parametersDCBuilderType.Type,
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      };
      if ((method as Method).HasParameters && !isBaseClient)
        typeArray[1] = this.dCTypeStore.GetDCBuilderType(service.Name + "_" + method.Name + "_Parameters").Type;
      MethodBuilder methodBuilder;
      if (!isBaseClient)
      {
        methodBuilder = typeBuilder.DefineMethod(method.Name, MethodAttributes.Public | MethodAttributes.HideBySig, statusDCBuilderType.Type, typeArray);
      }
      else
      {
        string name = this.nameSpacePrefix + "I" + service.Name + "Base." + method.Name;
        methodBuilder = typeBuilder.DefineMethod(name, MethodAttributes.Private | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, statusDCBuilderType.Type, typeArray);
        typeBuilder.DefineMethodOverride((MethodInfo) methodBuilder, dCBuilderType.Type.GetMethod(method.Name, typeArray));
      }
      methodBuilder.DefineParameter(1, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
      methodBuilder.DefineParameter(2, ParameterAttributes.None, "parameters");
      methodBuilder.DefineParameter(3, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(4, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      if (!isBaseClient)
      {
        ilGenerator.DeclareLocal(typeof (Exception));
        ilGenerator.DeclareLocal(statusDCBuilderType.Type);
        ilGenerator.DeclareLocal(typeof (bool));
        ilGenerator.Emit(OpCodes.Ldarg_S, 4);
        ilGenerator.Emit(OpCodes.Ldnull);
        ilGenerator.Emit(OpCodes.Stind_Ref);
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Ldstr, method.Name);
        ilGenerator.Emit(OpCodes.Ldarg_1);
        ilGenerator.Emit(OpCodes.Ldarg_2);
        ilGenerator.Emit(OpCodes.Ldarg_3);
        ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnBeforeCall", BindingFlags.Instance | BindingFlags.NonPublic));
        ilGenerator.BeginExceptionBlock();
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_IsTransactionOpened", BindingFlags.Instance | BindingFlags.NonPublic));
        ilGenerator.Emit(OpCodes.Ldc_I4_0);
        ilGenerator.Emit(OpCodes.Ceq);
        ilGenerator.Emit(OpCodes.Stloc_3);
        ilGenerator.Emit(OpCodes.Ldloc_3);
        Label label1 = ilGenerator.DefineLabel();
        ilGenerator.Emit(OpCodes.Brtrue_S, label1);
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Ldarg_1);
        ilGenerator.Emit(OpCodes.Ldc_I4, (int) dcBuilderType2.Type.GetField(method.Name).GetValue((object) null));
        ilGenerator.Emit(OpCodes.Ldarg_2);
        Type[] types = new Type[3]
        {
          cdoDCBuilderType.Type,
          dcBuilderType2.Type,
          parametersDCBuilderType.Type
        };
        ilGenerator.Emit(OpCodes.Newobj, dcBuilderType1.Type.GetConstructor(types));
        ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("AddMethod", BindingFlags.Instance | BindingFlags.NonPublic));
        ilGenerator.Emit(OpCodes.Stloc_0);
        Label label2 = ilGenerator.DefineLabel();
        ilGenerator.Emit(OpCodes.Br_S, label2);
        ilGenerator.MarkLabel(label1);
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_Channel", BindingFlags.Instance | BindingFlags.NonPublic));
        ilGenerator.Emit(OpCodes.Castclass, dCBuilderType.Type);
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_UserProfile", BindingFlags.Instance | BindingFlags.NonPublic));
        ilGenerator.Emit(OpCodes.Ldarg_1);
        ilGenerator.Emit(OpCodes.Ldarg_2);
        ilGenerator.Emit(OpCodes.Ldarg_3);
        ilGenerator.Emit(OpCodes.Ldarg_S, 4);
        ilGenerator.Emit(OpCodes.Callvirt, dCBuilderType.Type.GetMethod(method.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public));
        ilGenerator.Emit(OpCodes.Stloc_0);
        ilGenerator.MarkLabel(label2);
        ilGenerator.BeginCatchBlock(typeof (Exception));
        ilGenerator.Emit(OpCodes.Stloc_1);
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Ldloc_1);
        ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
        ilGenerator.Emit(OpCodes.Stloc_0);
        ilGenerator.EndExceptionBlock();
        ilGenerator.Emit(OpCodes.Ldloc_0);
        ilGenerator.Emit(OpCodes.Callvirt, statusDCBuilderType.Type.GetProperty("IsSuccess").GetGetMethod());
        ilGenerator.Emit(OpCodes.Ldc_I4_0);
        ilGenerator.Emit(OpCodes.Ceq);
        ilGenerator.Emit(OpCodes.Stloc_3);
        ilGenerator.Emit(OpCodes.Ldloc_3);
        Label label3 = ilGenerator.DefineLabel();
        ilGenerator.Emit(OpCodes.Brtrue_S, label3);
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Ldstr, method.Name);
        ilGenerator.Emit(OpCodes.Ldloc_0);
        ilGenerator.Emit(OpCodes.Ldarg_1);
        ilGenerator.Emit(OpCodes.Ldarg_2);
        ilGenerator.Emit(OpCodes.Ldarg_3);
        ilGenerator.Emit(OpCodes.Ldarg_S, 4);
        ilGenerator.Emit(OpCodes.Ldind_Ref);
        ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnAfterCall", BindingFlags.Instance | BindingFlags.NonPublic));
        ilGenerator.MarkLabel(label3);
        ilGenerator.Emit(OpCodes.Ldloc_0);
        ilGenerator.Emit(OpCodes.Stloc_2);
        Label label4 = ilGenerator.DefineLabel();
        ilGenerator.Emit(OpCodes.Br_S, label4);
        ilGenerator.MarkLabel(label4);
        ilGenerator.Emit(OpCodes.Ldloc_2);
      }
      else
      {
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Ldarg_1);
        ilGenerator.Emit(OpCodes.Ldarg_2);
        ilGenerator.Emit(OpCodes.Ldarg_3);
        ilGenerator.Emit(OpCodes.Ldarg_S, 4);
        ilGenerator.Emit(OpCodes.Callvirt, virtualMethod);
        ilGenerator.Emit(OpCodes.Stloc_0);
        Label label = ilGenerator.DefineLabel();
        ilGenerator.Emit(OpCodes.Br_S, label);
        ilGenerator.MarkLabel(label);
        ilGenerator.Emit(OpCodes.Ldloc_0);
      }
      ilGenerator.Emit(OpCodes.Ret);
      return (MethodInfo) methodBuilder;
    }

    private void ImplementConstructor(TypeBuilder typeBuilder, Type parentType)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType("UserProfile");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType("I" + typeBuilder.Name);
      Type[] parameterTypes = new Type[1]
      {
        dcBuilderType1.Type
      };
      ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, parameterTypes);
      constructorBuilder.DefineParameter(1, ParameterAttributes.None, "userProfile");
      ILGenerator ilGenerator = constructorBuilder.GetILGenerator();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Call, parentType.GetConstructor(Type.EmptyTypes));
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldtoken, dcBuilderType2.Type);
      ilGenerator.Emit(OpCodes.Call, typeof (Type).GetMethod("GetTypeFromHandle", BindingFlags.Static | BindingFlags.Public));
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Call, parentType.GetMethod("Initialize", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddCommitTransactionMethod(
      IService service,
      TypeBuilder typeBuilder,
      DCBuilderType dCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      Type baseType)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(service.Name + "Method");
      Type[] parameterTypes = new Type[2]
      {
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      };
      MethodBuilder mainMethod = typeBuilder.DefineMethod("CommitTransaction", MethodAttributes.Public | MethodAttributes.HideBySig, dcBuilderType1.Type, parameterTypes);
      mainMethod.DefineParameter(1, ParameterAttributes.None, "request");
      mainMethod.DefineParameter(2, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = mainMethod.GetILGenerator();
      ilGenerator.DeclareLocal(dcBuilderType2.Type.MakeArrayType());
      ilGenerator.DeclareLocal(typeof (Exception));
      ilGenerator.DeclareLocal(dcBuilderType1.Type);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.BeginExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("GetMethodCount", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Newarr, dcBuilderType2.Type);
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("CopyMethods", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_Channel", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Castclass, dCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_UserProfile", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Callvirt, dCBuilderType.Type.GetMethod("CommitTransaction", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public));
      ilGenerator.Emit(OpCodes.Stloc_2);
      ilGenerator.BeginCatchBlock(typeof (Exception));
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_2);
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc_2);
      ilGenerator.Emit(OpCodes.Ret);
      this.AddCommitTransactionOverride(typeBuilder, dcBuilderType1, requestDCBuilderType, resultDCBuilderType, baseType, mainMethod);
    }

    private void AddGetEnvironmentMethod(
      TypeBuilder typeBuilder,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType dCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      Type baseType)
    {
      DCBuilderType dcBuilderType = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      Type[] parameterTypes = new Type[3]
      {
        cdoDCBuilderType.Type,
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      };
      MethodBuilder mainMethod = typeBuilder.DefineMethod("GetEnvironment", MethodAttributes.Public | MethodAttributes.HideBySig, dcBuilderType.Type, parameterTypes);
      mainMethod.DefineParameter(1, ParameterAttributes.None, "cdo");
      mainMethod.DefineParameter(2, ParameterAttributes.None, "request");
      mainMethod.DefineParameter(3, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = mainMethod.GetILGenerator();
      ilGenerator.DeclareLocal(dcBuilderType.Type);
      ilGenerator.DeclareLocal(typeof (Exception));
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.BeginExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_Channel", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Castclass, dCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_UserProfile", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Callvirt, dCBuilderType.Type.GetMethod("GetEnvironment", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public));
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.BeginCatchBlock(typeof (Exception));
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ret);
      this.AddGetEnvironmentOverride(typeBuilder, dcBuilderType, cdoDCBuilderType, requestDCBuilderType, resultDCBuilderType, baseType, mainMethod);
      this.AddGetEnvironmentWithTwoParams(typeBuilder, dcBuilderType, requestDCBuilderType, resultDCBuilderType, mainMethod);
    }

    private void AddGetEnvironmentWithTwoParams(
      TypeBuilder typeBuilder,
      DCBuilderType statusDCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      MethodBuilder mainMethod)
    {
      Type[] parameterTypes = new Type[2]
      {
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("GetEnvironment", MethodAttributes.Public | MethodAttributes.HideBySig, statusDCBuilderType.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(2, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Call, (MethodInfo) mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_0);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddGetEnvironmentOverride(
      TypeBuilder typeBuilder,
      DCBuilderType statusDCBuilderType,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      Type baseType,
      MethodBuilder mainMethod)
    {
      Type[] parameterTypes = new Type[3]
      {
        this.dCTypeStore.GetDCBuilderType("DCObject").Type,
        this.dCTypeStore.GetDCBuilderType("Request").Type,
        this.dCTypeStore.GetDCBuilderType("Result").Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("OnGetEnvironment", MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, statusDCBuilderType.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "cdo");
      methodBuilder.DefineParameter(2, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(3, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      LocalBuilder local = ilGenerator.DeclareLocal(resultDCBuilderType.Type);
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.DeclareLocal(typeof (Exception));
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.BeginExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Castclass, cdoDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Castclass, requestDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldloca_S, local);
      ilGenerator.Emit(OpCodes.Call, (MethodInfo) mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.BeginCatchBlock(typeof (Exception));
      ilGenerator.Emit(OpCodes.Stloc_2);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_2);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc_3);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddCommitTransactionOverride(
      TypeBuilder typeBuilder,
      DCBuilderType statusDCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      Type baseType,
      MethodBuilder mainMethod)
    {
      Type[] parameterTypes = new Type[2]
      {
        this.dCTypeStore.GetDCBuilderType("Request").Type,
        this.dCTypeStore.GetDCBuilderType("Result").Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("OnCommitTransaction", MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, statusDCBuilderType.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(2, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      LocalBuilder local = ilGenerator.DeclareLocal(resultDCBuilderType.Type);
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.DeclareLocal(typeof (Exception));
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.BeginExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Castclass, requestDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldloca_S, local);
      ilGenerator.Emit(OpCodes.Call, (MethodInfo) mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.BeginCatchBlock(typeof (Exception));
      ilGenerator.Emit(OpCodes.Stloc_2);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_2);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc_3);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddExecuteTransactionMethod(
      IService service,
      TypeBuilder typeBuilder,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType dCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      Type baseType)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Parameters");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(service.Name + "Method");
      DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType(service.Name + "Methods");
      DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      Type[] parameterTypes = new Type[3]
      {
        cdoDCBuilderType.Type,
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      };
      MethodBuilder mainMethod = typeBuilder.DefineMethod("ExecuteTransaction", MethodAttributes.Public | MethodAttributes.HideBySig, dcBuilderType4.Type, parameterTypes);
      mainMethod.DefineParameter(1, ParameterAttributes.None, "cdo");
      mainMethod.DefineParameter(2, ParameterAttributes.None, "request");
      mainMethod.DefineParameter(3, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = mainMethod.GetILGenerator();
      ilGenerator.DeclareLocal(dcBuilderType4.Type);
      ilGenerator.DeclareLocal(typeof (Exception));
      ilGenerator.DeclareLocal(dcBuilderType4.Type);
      ilGenerator.DeclareLocal(typeof (bool));
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldstr, "ExecuteTransaction");
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnBeforeCall", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.BeginExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_IsTransactionOpened", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Ldc_I4_0);
      ilGenerator.Emit(OpCodes.Ceq);
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.Emit(OpCodes.Ldloc_3);
      Label label1 = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Brtrue_S, label1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldc_I4, (int) dcBuilderType3.Type.GetField("ExecuteTransaction").GetValue((object) null));
      ilGenerator.Emit(OpCodes.Ldnull);
      Type[] types = new Type[3]
      {
        cdoDCBuilderType.Type,
        dcBuilderType3.Type,
        dcBuilderType1.Type
      };
      ilGenerator.Emit(OpCodes.Newobj, dcBuilderType2.Type.GetConstructor(types));
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("AddMethod", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      Label label2 = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label2);
      ilGenerator.MarkLabel(label1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_Channel", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Castclass, dCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_UserProfile", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Callvirt, dCBuilderType.Type.GetMethod("ExecuteTransaction", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public));
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.MarkLabel(label2);
      ilGenerator.BeginCatchBlock(typeof (Exception));
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Callvirt, dcBuilderType4.Type.GetProperty("IsSuccess").GetGetMethod());
      ilGenerator.Emit(OpCodes.Ldc_I4_0);
      ilGenerator.Emit(OpCodes.Ceq);
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.Emit(OpCodes.Ldloc_3);
      Label label3 = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Brtrue_S, label3);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldstr, "ExecuteTransaction");
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldind_Ref);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnAfterCall", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.MarkLabel(label3);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Stloc_2);
      Label label4 = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label4);
      ilGenerator.MarkLabel(label4);
      ilGenerator.Emit(OpCodes.Ldloc_2);
      ilGenerator.Emit(OpCodes.Ret);
      this.AddExecuteTransactionOverride(typeBuilder, dcBuilderType4, cdoDCBuilderType, requestDCBuilderType, resultDCBuilderType, baseType, mainMethod);
      this.AddExecuteTransactionWithOneParam(typeBuilder, dcBuilderType4, cdoDCBuilderType, resultDCBuilderType, mainMethod);
      this.AddExecuteTransactionWithTwoParams(typeBuilder, dcBuilderType4, requestDCBuilderType, resultDCBuilderType, mainMethod);
    }

    private void AddExecuteTransactionWithOneParam(
      TypeBuilder typeBuilder,
      DCBuilderType statusDCBuilderType,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType resultDCBuilderType,
      MethodBuilder mainMethod)
    {
      Type[] parameterTypes = new Type[1]
      {
        cdoDCBuilderType.Type
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("ExecuteTransaction", MethodAttributes.Public | MethodAttributes.HideBySig, statusDCBuilderType.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "cdo");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(resultDCBuilderType.Type);
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldloca_S, 0);
      ilGenerator.Emit(OpCodes.Call, (MethodInfo) mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_1);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddExecuteTransactionWithTwoParams(
      TypeBuilder typeBuilder,
      DCBuilderType statusDCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      MethodBuilder mainMethod)
    {
      Type[] parameterTypes = new Type[2]
      {
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("ExecuteTransaction", MethodAttributes.Public | MethodAttributes.HideBySig, statusDCBuilderType.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(2, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Call, (MethodInfo) mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_0);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddExecuteTransactionOverride(
      TypeBuilder typeBuilder,
      DCBuilderType statusDCBuilderType,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType,
      Type baseType,
      MethodBuilder mainMethod)
    {
      Type[] parameterTypes = new Type[3]
      {
        this.dCTypeStore.GetDCBuilderType("DCObject").Type,
        this.dCTypeStore.GetDCBuilderType("Request").Type,
        this.dCTypeStore.GetDCBuilderType("Result").Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("OnExecuteTransaction", MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, statusDCBuilderType.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "cdo");
      methodBuilder.DefineParameter(2, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(3, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      LocalBuilder local = ilGenerator.DeclareLocal(resultDCBuilderType.Type);
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.DeclareLocal(typeof (Exception));
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.BeginExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Castclass, cdoDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Castclass, requestDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Ldloca_S, local);
      ilGenerator.Emit(OpCodes.Call, (MethodInfo) mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.BeginCatchBlock(typeof (Exception));
      ilGenerator.Emit(OpCodes.Stloc_2);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_2);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc_3);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddAddDataTransactionMethod(
      ServiceBase service,
      TypeBuilder typeBuilder,
      DCBuilderType cdoDCBuilderType,
      DCBuilderType dCBuilderType,
      Type baseType)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Parameters");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(service.Name + "Method");
      DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType("Result");
      DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType(service.Name + "Methods");
      DCBuilderType dcBuilderType5 = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      Type[] parameterTypes = new Type[1]
      {
        cdoDCBuilderType.Type
      };
      MethodBuilder mainMethod = typeBuilder.DefineMethod("AddDataTransaction", MethodAttributes.Public | MethodAttributes.HideBySig, dcBuilderType5.Type, parameterTypes);
      mainMethod.DefineParameter(1, ParameterAttributes.None, "cdo");
      ILGenerator ilGenerator = mainMethod.GetILGenerator();
      ilGenerator.DeclareLocal(dcBuilderType5.Type);
      ilGenerator.DeclareLocal(typeof (Exception));
      ilGenerator.DeclareLocal(dcBuilderType5.Type);
      ilGenerator.DeclareLocal(typeof (bool));
      ilGenerator.DeclareLocal(dcBuilderType3.Type);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldstr, "AddDataTransaction");
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnBeforeCall", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.BeginExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldfld, baseType.GetField("_IsTransactionOpened", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Ldc_I4_0);
      ilGenerator.Emit(OpCodes.Ceq);
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.Emit(OpCodes.Ldloc_3);
      Label label1 = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Brtrue_S, label1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldc_I4, (int) dcBuilderType4.Type.GetField("AddDataTransaction").GetValue((object) null));
      ilGenerator.Emit(OpCodes.Ldnull);
      Type[] types = new Type[3]
      {
        cdoDCBuilderType.Type,
        dcBuilderType4.Type,
        dcBuilderType1.Type
      };
      ilGenerator.Emit(OpCodes.Newobj, dcBuilderType2.Type.GetConstructor(types));
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("AddMethod", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      Label label2 = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label2);
      ilGenerator.MarkLabel(label1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("GetAddDataTransactionException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.MarkLabel(label2);
      ilGenerator.BeginCatchBlock(typeof (Exception));
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Callvirt, dcBuilderType5.Type.GetProperty("IsSuccess").GetGetMethod());
      ilGenerator.Emit(OpCodes.Ldc_I4_0);
      ilGenerator.Emit(OpCodes.Ceq);
      ilGenerator.Emit(OpCodes.Stloc_3);
      ilGenerator.Emit(OpCodes.Ldloc_3);
      Label label3 = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Brtrue_S, label3);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldstr, "AddDataTransaction");
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldloc_S, 4);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnAfterCall", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.MarkLabel(label3);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Stloc_2);
      Label label4 = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label4);
      ilGenerator.MarkLabel(label4);
      ilGenerator.Emit(OpCodes.Ldloc_2);
      ilGenerator.Emit(OpCodes.Ret);
      this.AddAddDataTransactionOverride(typeBuilder, dcBuilderType5, cdoDCBuilderType, baseType, mainMethod);
    }

    private void AddAddDataTransactionOverride(
      TypeBuilder typeBuilder,
      DCBuilderType statusDCBuilderType,
      DCBuilderType cdoDCBuilderType,
      Type baseType,
      MethodBuilder mainMethod)
    {
      Type[] parameterTypes = new Type[1]
      {
        this.dCTypeStore.GetDCBuilderType("DCObject").Type
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("OnAddDataTransaction", MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, statusDCBuilderType.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "cdo");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(statusDCBuilderType.Type);
      ilGenerator.DeclareLocal(typeof (Exception));
      ilGenerator.BeginExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Castclass, cdoDCBuilderType.Type);
      ilGenerator.Emit(OpCodes.Call, (MethodInfo) mainMethod);
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.BeginCatchBlock(typeof (Exception));
      ilGenerator.Emit(OpCodes.Stloc_1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldloc_1);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("OnThrowException", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      ilGenerator.EndExceptionBlock();
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ret);
    }
  }
}
