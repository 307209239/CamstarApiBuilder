// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.ServiceGenerator
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Camstar.WCF.Generator
{
  internal class ServiceGenerator : ServiceAssemblyGeneratorBase
  {
    public ServiceGenerator(ModuleBuilder moduleBuilder, DCTypeStore dCTypeStore, string nameSpace)
      : base(nameSpace, moduleBuilder, dCTypeStore)
    {
    }

    public override void AddService(ServiceBase service)
    {
      if (service.ExposedState == ExposedServiceStateType.Base)
        return;
      this.AddServiceInterface(service);
      Type type = this.dCTypeStore.GetDCBuilderType("ServiceBase").Type;
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType("I" + service.Name + "Service");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(service.Name);
      TypeBuilder typeBuilder = this.moduleBuilder.DefineType(this.nameSpacePrefix + service.Name + "Service", TypeAttributes.Public, type, new Type[1]
      {
        dcBuilderType1.Type
      });
      DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Request");
      DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Result");
      DCBuilderType dcBuilderType5 = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      DCBuilderType dcBuilderType6 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Parameters");
      DCBuilderType dcBuilderType7 = this.dCTypeStore.GetDCBuilderType("UserProfile");
      foreach (IMethod method1 in service.GetMethods())
      {
        if (method1.ExposedState == ExposedMethodStateType.Exposed || method1.ExposedState == ExposedMethodStateType.BaseAndExposed)
        {
          Method method2 = method1 as Method;
          Type[] parameterTypes = new Type[5]
          {
            dcBuilderType7.Type,
            dcBuilderType2.Type,
            dcBuilderType6.Type,
            dcBuilderType3.Type,
            dcBuilderType4.Type.MakeByRefType()
          };
          if (method2.HasParameters)
            parameterTypes[2] = this.dCTypeStore.GetDCBuilderType(service.Name + "_" + method2.Name + "_Parameters").Type;
          MethodBuilder methodBuilder = typeBuilder.DefineMethod(method2.Name, MethodAttributes.Public | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.VtableLayoutMask, dcBuilderType5.Type, parameterTypes);
          methodBuilder.DefineParameter(1, ParameterAttributes.None, "userProfile");
          methodBuilder.DefineParameter(2, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
          methodBuilder.DefineParameter(3, ParameterAttributes.None, "parameters");
          methodBuilder.DefineParameter(4, ParameterAttributes.None, "request");
          methodBuilder.DefineParameter(5, ParameterAttributes.Out, "result");
          ILGenerator ilGenerator = methodBuilder.GetILGenerator();
          ilGenerator.DeclareLocal(dcBuilderType5.Type);
          ilGenerator.Emit(OpCodes.Ldarg_S, 5);
          ilGenerator.Emit(OpCodes.Newobj, dcBuilderType4.Type.GetConstructor(Type.EmptyTypes));
          ilGenerator.Emit(OpCodes.Stind_Ref);
          ilGenerator.Emit(OpCodes.Ldarg_0);
          ilGenerator.Emit(OpCodes.Ldstr, method2.Name);
          ilGenerator.Emit(OpCodes.Ldarg_1);
          ilGenerator.Emit(OpCodes.Ldarg_2);
          ilGenerator.Emit(OpCodes.Ldarg_3);
          ilGenerator.Emit(OpCodes.Ldarg_S, 4);
          ilGenerator.Emit(OpCodes.Ldarg_S, 5);
          ilGenerator.Emit(OpCodes.Ldind_Ref);
          ilGenerator.Emit(OpCodes.Call, type.GetMethod("CallMethod", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic));
          ilGenerator.Emit(OpCodes.Stloc_0);
          Label label = ilGenerator.DefineLabel();
          ilGenerator.Emit(OpCodes.Br_S, label);
          ilGenerator.MarkLabel(label);
          ilGenerator.Emit(OpCodes.Ldloc_0);
          ilGenerator.Emit(OpCodes.Ret);
        }
      }
      this.AddCommitTransactionMethod(service, typeBuilder, type);
      this.AddExecuteTransactionMethod(service, typeBuilder, type);
      this.AddGetEnvironmentMethod(service, typeBuilder, type);
      typeBuilder.CreateType();
    }

    private void AddExecuteTransactionMethod(
      ServiceBase service,
      TypeBuilder typeBuilder,
      Type baseType)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType(service.Name);
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Request");
      DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Result");
      DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      Type[] parameterTypes = new Type[4]
      {
        this.dCTypeStore.GetDCBuilderType("UserProfile").Type,
        dcBuilderType1.Type,
        dcBuilderType2.Type,
        dcBuilderType3.Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("ExecuteTransaction", MethodAttributes.Public | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.VtableLayoutMask, dcBuilderType4.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "userProfile");
      methodBuilder.DefineParameter(2, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
      methodBuilder.DefineParameter(3, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(4, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(dcBuilderType4.Type);
      ilGenerator.Emit(OpCodes.Ldarg_S, 4);
      ilGenerator.Emit(OpCodes.Newobj, dcBuilderType3.Type.GetConstructor(Type.EmptyTypes));
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldstr, "ExecuteTransaction");
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldarg_S, 4);
      ilGenerator.Emit(OpCodes.Ldind_Ref);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("CallMethod", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddCommitTransactionMethod(
      ServiceBase service,
      TypeBuilder typeBuilder,
      Type baseType)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType(service.Name + "Method");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Request");
      DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Result");
      DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      Type[] parameterTypes = new Type[4]
      {
        this.dCTypeStore.GetDCBuilderType("UserProfile").Type,
        dcBuilderType1.Type.MakeArrayType(),
        dcBuilderType2.Type,
        dcBuilderType3.Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("CommitTransaction", MethodAttributes.Public | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.VtableLayoutMask, dcBuilderType4.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "userProfile");
      methodBuilder.DefineParameter(2, ParameterAttributes.None, "methods");
      methodBuilder.DefineParameter(3, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(4, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(dcBuilderType4.Type);
      ilGenerator.DeclareLocal(dcBuilderType4.Type);
      ilGenerator.Emit(OpCodes.Ldarg_S, 4);
      ilGenerator.Emit(OpCodes.Newobj, dcBuilderType3.Type.GetConstructor(Type.EmptyTypes));
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldstr, "CommitTransaction");
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldarg_S, 4);
      ilGenerator.Emit(OpCodes.Ldind_Ref);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("CallMethods", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ret);
    }

    private void AddGetEnvironmentMethod(
      ServiceBase service,
      TypeBuilder typeBuilder,
      Type baseType)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType(service.Name);
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Request");
      DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Result");
      DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      Type[] parameterTypes = new Type[4]
      {
        this.dCTypeStore.GetDCBuilderType("UserProfile").Type,
        dcBuilderType1.Type,
        dcBuilderType2.Type,
        dcBuilderType3.Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("GetEnvironment", MethodAttributes.Public | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.VtableLayoutMask, dcBuilderType4.Type, parameterTypes);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "userProfile");
      methodBuilder.DefineParameter(2, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
      methodBuilder.DefineParameter(3, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(4, ParameterAttributes.Out, "result");
      ILGenerator ilGenerator = methodBuilder.GetILGenerator();
      ilGenerator.DeclareLocal(dcBuilderType4.Type);
      ilGenerator.DeclareLocal(dcBuilderType4.Type);
      ilGenerator.Emit(OpCodes.Ldarg_S, 4);
      ilGenerator.Emit(OpCodes.Newobj, dcBuilderType3.Type.GetConstructor(Type.EmptyTypes));
      ilGenerator.Emit(OpCodes.Stind_Ref);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldstr, "GetEnvironment");
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Ldnull);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Ldarg_S, 4);
      ilGenerator.Emit(OpCodes.Ldind_Ref);
      ilGenerator.Emit(OpCodes.Call, baseType.GetMethod("CallMethod", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator.Emit(OpCodes.Stloc_0);
      Label label = ilGenerator.DefineLabel();
      ilGenerator.Emit(OpCodes.Br_S, label);
      ilGenerator.MarkLabel(label);
      ilGenerator.Emit(OpCodes.Ldloc_0);
      ilGenerator.Emit(OpCodes.Ret);
    }
  }
}
