// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.ServiceAssemblyGeneratorBase
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;
using Camstar.WCF.ObjectStack;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.ServiceModel;

namespace Camstar.WCF.Generator
{
  internal abstract class ServiceAssemblyGeneratorBase : AssemblyGeneratorBase
  {
    protected const string openSessionMethodName = "OpenSession";
    protected const string beginTransactionMethodName = "BeginTransaction";
    protected const string rollBackTransactionMethodName = "RollBackTransaction";
    protected const string commitTransactionMethodName = "CommitTransaction";
    protected const string getEnvironmentMethodName = "GetEnvironment";
    protected const string executeTransactionMethodName = "ExecuteTransaction";
    protected const string addDataTransactionMethodName = "AddDataTransaction";
    private ILGenerator _EqualsGenerator;
    private System.Reflection.Emit.Label _EndLabel;

    public ServiceAssemblyGeneratorBase(
      string nameSpace,
      ModuleBuilder moduleBuilder,
      DCTypeStore dCTypeStore)
      : base(nameSpace, moduleBuilder, dCTypeStore)
    {
    }

    public abstract void AddService(ServiceBase service);

    public override void AddDC(DCType dCType)
    {
      bool isPrivate = this is ClientGenerator;
      if (dCType.IsEnum)
        return;
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType(dCType.ParentName);
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(dCType.Name);
      DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType(dCType.Name + "_Environment");
      DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType(dCType.Name + "_Info");
      if (isPrivate)
        this.BeginOverrideMethods(dcBuilderType2.TypeBuilder);
      foreach (DCField field in dCType.GetFields())
      {
        DCBuilderType dcBuilderType5 = this.dCTypeStore.GetDCBuilderType(field.TypeName);
        Type type = dcBuilderType5.Type;
        if (field.IsList)
          type = dcBuilderType5.Type.MakeArrayType();
        FieldInfo fieldInfo = dcBuilderType1.Type.GetField((isPrivate ? "_" : "") + field.Name, (BindingFlags) (4 | (!isPrivate || this._IsSilverlight ? 16 : 32)));
        if (!field.IsSimpleType)
        {
          if (fieldInfo != (FieldInfo) null)
          {
            try
            {
              Type fieldType = fieldInfo.FieldType;
            }
            catch (TypeLoadException ex)
            {
              fieldInfo = (FieldInfo) null;
            }
          }
        }
        if (field.IsActual(fieldInfo == (FieldInfo) null ? string.Empty : (fieldInfo.FieldType.IsArray ? fieldInfo.FieldType.GetElementType().Name : fieldInfo.FieldType.Name)))
        {
          FieldBuilder fieldBuilder = this.DefineField(dcBuilderType2.TypeBuilder, field.Name, type, isPrivate);
          if (isPrivate)
            this.AddFieldOverrideMethods(dcBuilderType2.TypeBuilder, fieldBuilder);
          this.DefineField(dcBuilderType3.TypeBuilder, field.Name, this.GetEnvironmentType(dcBuilderType5), field, isPrivate);
          this.DefineField(dcBuilderType4.TypeBuilder, field.Name, this.GetInfoType(dcBuilderType5), isPrivate);
          if (isPrivate)
          {
            this.DefineProperty(dcBuilderType2.TypeBuilder, field.Name, type);
            this.DefineProperty(dcBuilderType3.TypeBuilder, field.Name, this.GetEnvironmentType(dcBuilderType5), field);
            this.DefineProperty(dcBuilderType4.TypeBuilder, field.Name, this.GetInfoType(dcBuilderType5));
          }
        }
      }
      if (isPrivate)
        this.EndOverrideMethods(dcBuilderType1.Type);
      this.DefineTypeConstructor(dcBuilderType2.TypeBuilder, dcBuilderType1.Type);
      dcBuilderType2.TypeBuilder.CreateType();
      dcBuilderType3.TypeBuilder.CreateType();
      dcBuilderType4.TypeBuilder.CreateType();
    }

    protected void AddServiceInterface(ServiceBase service)
    {
      bool isForClient = this is ClientGenerator;
      if (service.ExposedState != ExposedServiceStateType.Exposed && !this._IsSilverlight)
      {
        DCBuilderType dcBuilderType1 = (DCBuilderType) null;
        if (service.ParentWCFServiceBaseType != null)
          dcBuilderType1 = this.dCTypeStore.GetDCBuilderType("I" + service.ParentWCFServiceBaseType.Name + "Base");
        if (dcBuilderType1 == null)
          dcBuilderType1 = this.dCTypeStore.GetDCBuilderType("IWCFService");
        if (dcBuilderType1 != null)
        {
          TypeBuilder typeBuilder = this.moduleBuilder.DefineType(this.nameSpacePrefix + "I" + service.Name + "Base", TypeAttributes.Public | TypeAttributes.ClassSemanticsMask | TypeAttributes.Abstract, (Type) null, new Type[1]
          {
            dcBuilderType1.Type
          });
          DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType("DCObject");
          DCBuilderType dcBuilderType3 = this.dCTypeStore.GetDCBuilderType("Request");
          DCBuilderType dcBuilderType4 = this.dCTypeStore.GetDCBuilderType("Result");
          DCBuilderType dcBuilderType5 = this.dCTypeStore.GetDCBuilderType("Parameters");
          List<MethodInfo> methodInfoList = new List<MethodInfo>();
          methodInfoList.AddRange((IEnumerable<MethodInfo>) dcBuilderType1.Type.GetMethods(BindingFlags.Instance | BindingFlags.Public));
          foreach (Type type in dcBuilderType1.Type.GetInterfaces())
            methodInfoList.AddRange((IEnumerable<MethodInfo>) type.GetMethods(BindingFlags.Instance | BindingFlags.Public));
          foreach (IMethod method1 in service.GetMethods())
          {
            if (method1.ExposedState == ExposedMethodStateType.Base || method1.ExposedState == ExposedMethodStateType.BaseAndExposed)
            {
              if (method1.IsInherited)
              {
                bool flag = false;
                foreach (MethodInfo methodInfo in methodInfoList)
                {
                  if (method1.Name == methodInfo.Name)
                    flag = true;
                }
                if (flag)
                  continue;
              }
              Method method2 = method1 as Method;
              Type[] parameterTypes1 = new Type[4]
              {
                dcBuilderType2.Type,
                dcBuilderType5.Type,
                dcBuilderType3.Type,
                dcBuilderType4.Type.MakeByRefType()
              };
              MethodBuilder methodBuilder1 = this.DefineMethod(method2.Name, parameterTypes1, typeBuilder);
              methodBuilder1.DefineParameter(1, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
              methodBuilder1.DefineParameter(2, ParameterAttributes.None, "parameters");
              methodBuilder1.DefineParameter(3, ParameterAttributes.None, "request");
              methodBuilder1.DefineParameter(4, ParameterAttributes.Out, "result");
              Type[] parameterTypes2 = new Type[3]
              {
                dcBuilderType2.Type,
                dcBuilderType3.Type,
                dcBuilderType4.Type.MakeByRefType()
              };
              MethodBuilder methodBuilder2 = this.DefineMethod(method2.Name, parameterTypes2, typeBuilder);
              methodBuilder2.DefineParameter(1, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
              methodBuilder2.DefineParameter(2, ParameterAttributes.None, "request");
              methodBuilder2.DefineParameter(3, ParameterAttributes.Out, "result");
              Type[] parameterTypes3 = new Type[1]
              {
                dcBuilderType2.Type
              };
              this.DefineMethod(method2.Name, parameterTypes3, typeBuilder).DefineParameter(1, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
              this.DefineMethod(method2.Name, Type.EmptyTypes, typeBuilder);
            }
          }
          this.dCTypeStore.Add("I" + service.Name + "Base", typeBuilder.CreateType(), typeBuilder);
        }
      }
      if (service.ExposedState == ExposedServiceStateType.Base)
        return;
      TypeBuilder typeBuilder1 = (TypeBuilder) null;
      if (!this._IsSilverlight)
      {
        typeBuilder1 = this.moduleBuilder.DefineType(this.nameSpacePrefix + "I" + service.Name + "Service", TypeAttributes.Public | TypeAttributes.ClassSemanticsMask | TypeAttributes.Abstract);
        CustomAttributeBuilder customBuilder = new CustomAttributeBuilder(typeof (ServiceContractAttribute).GetConstructor(Type.EmptyTypes), new object[0]);
        typeBuilder1.SetCustomAttribute(customBuilder);
      }
      DCBuilderType dcBuilderType6 = this.dCTypeStore.GetDCBuilderType(service.Name);
      this.AddResultType(dcBuilderType6, isForClient);
      this.AddRequestType(dcBuilderType6, isForClient);
      this.AddParameterType(dcBuilderType6);
      DCBuilderType dcBuilderType7 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Request");
      DCBuilderType dcBuilderType8 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Result");
      DCBuilderType dcBuilderType9 = this.dCTypeStore.GetDCBuilderType(service.Name + "_Parameters");
      DCBuilderType dcBuilderType10 = this.dCTypeStore.GetDCBuilderType("UserProfile");
      EnumBuilder enumBuilder1 = this.DefineEnum(this.nameSpacePrefix + service.Name + "Methods");
      int num = 0;
      foreach (IMethod method1 in service.GetMethods())
      {
        if (method1.ExposedState == ExposedMethodStateType.Exposed || method1.ExposedState == ExposedMethodStateType.BaseAndExposed)
        {
          Method method2 = method1 as Method;
          Type[] parameterTypes = new Type[5]
          {
            dcBuilderType10.Type,
            dcBuilderType6.Type,
            dcBuilderType9.Type,
            dcBuilderType7.Type,
            dcBuilderType8.Type.MakeByRefType()
          };
          if (method2.HasParameters)
          {
            this.AddMethodParametersType(service.Name, method2, isForClient);
            parameterTypes[2] = this.dCTypeStore.GetDCBuilderType(service.Name + "_" + method2.Name + "_Parameters").Type;
          }
          if (!this._IsSilverlight)
          {
            MethodBuilder methodBuilder = this.DefineMethod(method2.Name, parameterTypes, typeBuilder1);
            methodBuilder.DefineParameter(1, ParameterAttributes.None, "userProfile");
            methodBuilder.DefineParameter(2, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
            methodBuilder.DefineParameter(3, ParameterAttributes.None, "parameters");
            methodBuilder.DefineParameter(4, ParameterAttributes.None, "request");
            methodBuilder.DefineParameter(5, ParameterAttributes.Out, "result");
          }
          this.DefineLiteral(enumBuilder1, method1.Name, num++, (string) null, (DCField) null);
        }
      }
      EnumBuilder enumBuilder2 = enumBuilder1;
      int number1 = num;
      int number2 = number1 + 1;
      this.DefineLiteral(enumBuilder2, "ExecuteTransaction", number1, (string) null, (DCField) null);
      this.DefineLiteral(enumBuilder1, "AddDataTransaction", number2, (string) null, (DCField) null);
      this.dCTypeStore.Add(service.Name + "Methods", enumBuilder1.CreateType(), (TypeBuilder) null);
      DCBuilderType dcBuilderType11 = this.dCTypeStore.GetDCBuilderType(service.Name + "Methods");
      this.AddMethodType(service.Name, dcBuilderType11, dcBuilderType9);
      if (this._IsSilverlight)
        return;
      this.AddCommitTransactionMethod(service, dcBuilderType10, typeBuilder1, dcBuilderType7, dcBuilderType8);
      this.AddExecuteTransactionMethod(service, dcBuilderType10, typeBuilder1, dcBuilderType6, dcBuilderType7, dcBuilderType8);
      this.AddGetEnvironmentMethod(service, dcBuilderType10, typeBuilder1, dcBuilderType6, dcBuilderType7, dcBuilderType8);
      this.dCTypeStore.Add("I" + service.Name + "Service", typeBuilder1.CreateType(), typeBuilder1);
    }

    private void AddExecuteTransactionMethod(
      ServiceBase service,
      DCBuilderType userProfileDCBuilderType,
      TypeBuilder typeBuilder,
      DCBuilderType dCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType)
    {
      MethodBuilder methodBuilder = this.DefineMethod("ExecuteTransaction", new Type[4]
      {
        userProfileDCBuilderType.Type,
        dCBuilderType.Type,
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      }, typeBuilder);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "userProfile");
      methodBuilder.DefineParameter(2, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
      methodBuilder.DefineParameter(3, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(4, ParameterAttributes.Out, "result");
    }

    private void AddCommitTransactionMethod(
      ServiceBase service,
      DCBuilderType userProfileDCBuilderType,
      TypeBuilder typeBuilder,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType)
    {
      DCBuilderType dcBuilderType = this.dCTypeStore.GetDCBuilderType(service.Name + "Method");
      Type[] typeArray = new Type[4]
      {
        userProfileDCBuilderType.Type,
        dcBuilderType.Type.MakeArrayType(),
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      };
      MethodBuilder methodBuilder = this.DefineMethod("CommitTransaction", new Type[4]
      {
        userProfileDCBuilderType.Type,
        dcBuilderType.Type.MakeArrayType(),
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      }, typeBuilder);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "userProfile");
      methodBuilder.DefineParameter(2, ParameterAttributes.None, "methods");
      methodBuilder.DefineParameter(3, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(4, ParameterAttributes.Out, "result");
    }

    private void AddGetEnvironmentMethod(
      ServiceBase service,
      DCBuilderType userProfileDCBuilderType,
      TypeBuilder typeBuilder,
      DCBuilderType dCBuilderType,
      DCBuilderType requestDCBuilderType,
      DCBuilderType resultDCBuilderType)
    {
      MethodBuilder methodBuilder = this.DefineMethod("GetEnvironment", new Type[4]
      {
        userProfileDCBuilderType.Type,
        dCBuilderType.Type,
        requestDCBuilderType.Type,
        resultDCBuilderType.Type.MakeByRefType()
      }, typeBuilder);
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "userProfile");
      methodBuilder.DefineParameter(2, ParameterAttributes.None, service.Name.Substring(0, 1).ToLower() + service.Name.Substring(1));
      methodBuilder.DefineParameter(3, ParameterAttributes.None, "request");
      methodBuilder.DefineParameter(4, ParameterAttributes.Out, "result");
    }

    private void AddMethodType(
      string serviceName,
      DCBuilderType enumDCBuilderType,
      DCBuilderType parametersDCBuilderType)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType(serviceName);
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType("Method");
      TypeBuilder typeBuilder = this.DefineType(this.nameSpacePrefix + serviceName + "Method", dcBuilderType2.Type);
      FieldBuilder fieldBuilder1 = this.DefineUniqueField(typeBuilder, "Cdo", dcBuilderType1.Type, false);
      FieldBuilder fieldBuilder2 = this.DefineUniqueField(typeBuilder, "ServiceMethod", enumDCBuilderType.Type, false);
      FieldBuilder fieldBuilder3 = this.DefineUniqueField(typeBuilder, "Parameters", parametersDCBuilderType.Type, false);
      Type[] parameterTypes = new Type[3]
      {
        dcBuilderType1.Type,
        enumDCBuilderType.Type,
        parametersDCBuilderType.Type
      };
      ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, parameterTypes);
      constructorBuilder.DefineParameter(1, ParameterAttributes.None, "Cdo");
      constructorBuilder.DefineParameter(2, ParameterAttributes.None, "Method");
      constructorBuilder.DefineParameter(3, ParameterAttributes.None, "Parameters");
      ILGenerator ilGenerator = constructorBuilder.GetILGenerator();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Call, dcBuilderType2.Type.GetConstructor(Type.EmptyTypes));
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_1);
      ilGenerator.Emit(OpCodes.Stfld, (FieldInfo) fieldBuilder1);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_2);
      ilGenerator.Emit(OpCodes.Stfld, (FieldInfo) fieldBuilder2);
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldarg_3);
      ilGenerator.Emit(OpCodes.Stfld, (FieldInfo) fieldBuilder3);
      ilGenerator.Emit(OpCodes.Ret);
      this.dCTypeStore.Add(serviceName + "Method", typeBuilder.CreateType(), typeBuilder);
    }

    private void AddParameterType(DCBuilderType dCBuilderType)
    {
      DCBuilderType dcBuilderType = this.dCTypeStore.GetDCBuilderType("Parameters");
      TypeBuilder typeBuilder = this.DefineType(this.nameSpacePrefix + dCBuilderType.Name + "_Parameters", dcBuilderType.Type);
      this.dCTypeStore.Add(dCBuilderType.Name + "_Parameters", typeBuilder.CreateType(), typeBuilder);
    }

    private void AddResultType(DCBuilderType dCBuilderType, bool isForClient)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType("Result");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(dCBuilderType.Name + "_Environment");
      TypeBuilder typeBuilder = this.DefineType(this.nameSpacePrefix + dCBuilderType.Name + "_Result", dcBuilderType1.Type);
      this.DefineUniqueField(typeBuilder, "Value", dCBuilderType.Type, isForClient);
      this.DefineUniqueField(typeBuilder, "Environment", dcBuilderType2.Type, isForClient);
      if (isForClient)
      {
        this.DefineProperty(typeBuilder, "Value", dCBuilderType.Type);
        this.DefineProperty(typeBuilder, "Environment", dcBuilderType2.Type);
      }
      this.dCTypeStore.Add(dCBuilderType.Name + "_Result", typeBuilder.CreateType(), typeBuilder);
    }

    private void AddRequestType(DCBuilderType dCBuilderType, bool isForClient)
    {
      DCBuilderType dcBuilderType1 = this.dCTypeStore.GetDCBuilderType("Request");
      DCBuilderType dcBuilderType2 = this.dCTypeStore.GetDCBuilderType(dCBuilderType.Name + "_Info");
      TypeBuilder typeBuilder = this.DefineType(this.nameSpacePrefix + dCBuilderType.Name + "_Request", dcBuilderType1.Type);
      this.DefineUniqueField(typeBuilder, "Info", dcBuilderType2.Type, isForClient);
      if (isForClient)
        this.DefineProperty(typeBuilder, "Info", dcBuilderType2.Type);
      this.dCTypeStore.Add(dCBuilderType.Name + "_Request", typeBuilder.CreateType(), typeBuilder);
    }

    private void AddMethodParametersType(string serviceName, Method method, bool isForClient)
    {
      DCBuilderType dcBuilderType = this.dCTypeStore.GetDCBuilderType(serviceName + "_Parameters");
      TypeBuilder typeBuilder = this.DefineType(this.nameSpacePrefix + serviceName + "_" + method.Name + "_Parameters", dcBuilderType.Type);
      foreach (Parameter parameter in method.Parameters)
      {
        this.DefineUniqueField(typeBuilder, parameter.Name, typeof (string), isForClient);
        if (isForClient)
          this.DefineProperty(typeBuilder, parameter.Name, typeof (string));
      }
      this.dCTypeStore.Add(serviceName + "_" + method.Name + "_Parameters", typeBuilder.CreateType(), typeBuilder);
    }

    private Type GetEnvironmentType(DCBuilderType dCBuilderType)
    {
      Type type = this.dCTypeStore.GetDCBuilderType("Environment").Type;
      if (!dCBuilderType.IsSimpleType)
        type = this.dCTypeStore.GetDCBuilderType(dCBuilderType.Name + "_Environment").Type;
      return type;
    }

    private Type GetInfoType(DCBuilderType dCBuilderType)
    {
      Type type = this.dCTypeStore.GetDCBuilderType("Info").Type;
      if (!dCBuilderType.IsSimpleType)
        type = this.dCTypeStore.GetDCBuilderType(dCBuilderType.Name + "_Info").Type;
      return type;
    }

    protected MethodBuilder DefineMethod(
      string name,
      Type[] parameterTypes,
      TypeBuilder typeBuilder)
    {
      DCBuilderType dcBuilderType = this.dCTypeStore.GetDCBuilderType("ResultStatus");
      MethodBuilder methodBuilder = typeBuilder.DefineMethod(name, MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.Abstract, CallingConventions.Standard, dcBuilderType.Type, parameterTypes);
      CustomAttributeBuilder customBuilder = new CustomAttributeBuilder(typeof (OperationContractAttribute).GetConstructor(Type.EmptyTypes), new object[0]);
      methodBuilder.SetCustomAttribute(customBuilder);
      return methodBuilder;
    }

    private void AddFieldOverrideMethods(TypeBuilder typeBuilder, FieldBuilder fieldBuilder)
    {
      if (fieldBuilder.FieldType.IsArray)
        this._EqualsGenerator.Emit(OpCodes.Ldarg_0);
      this._EqualsGenerator.Emit(OpCodes.Ldarg_0);
      this._EqualsGenerator.Emit(OpCodes.Ldfld, (FieldInfo) fieldBuilder);
      this._EqualsGenerator.Emit(OpCodes.Ldarg_1);
      this._EqualsGenerator.Emit(OpCodes.Castclass, (Type) typeBuilder);
      this._EqualsGenerator.Emit(OpCodes.Ldfld, (FieldInfo) fieldBuilder);
      if (fieldBuilder.FieldType.IsArray)
        this._EqualsGenerator.Emit(OpCodes.Call, typeof (WCFObjectBase).GetMethod("CompareArrays", BindingFlags.Instance | BindingFlags.NonPublic));
      else
        this._EqualsGenerator.Emit(OpCodes.Call, typeof (object).GetMethod("Equals", BindingFlags.Static | BindingFlags.Public));
      this._EqualsGenerator.Emit(OpCodes.Brfalse, this._EndLabel);
    }

    private void BeginOverrideMethods(TypeBuilder typeBuilder)
    {
      MethodBuilder methodBuilder = typeBuilder.DefineMethod("Equals", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig, typeof (bool), new Type[1]
      {
        typeof (object)
      });
      methodBuilder.DefineParameter(1, ParameterAttributes.None, "obj");
      this._EqualsGenerator = methodBuilder.GetILGenerator();
      this._EqualsGenerator.DeclareLocal(typeof (bool));
      this._EqualsGenerator.Emit(OpCodes.Nop);
      this._EqualsGenerator.Emit(OpCodes.Ldarg_1);
      this._EndLabel = this._EqualsGenerator.DefineLabel();
      this._EqualsGenerator.Emit(OpCodes.Isinst, (Type) typeBuilder);
      this._EqualsGenerator.Emit(OpCodes.Brfalse, this._EndLabel);
    }

    private void EndOverrideMethods(Type parentType)
    {
      this._EqualsGenerator.Emit(OpCodes.Ldarg_0);
      this._EqualsGenerator.Emit(OpCodes.Ldarg_1);
      this._EqualsGenerator.Emit(OpCodes.Call, parentType.GetMethod("Equals", BindingFlags.Instance | BindingFlags.Public));
      System.Reflection.Emit.Label label1 = this._EqualsGenerator.DefineLabel();
      this._EqualsGenerator.Emit(OpCodes.Br_S, label1);
      this._EqualsGenerator.MarkLabel(this._EndLabel);
      this._EqualsGenerator.Emit(OpCodes.Ldc_I4_0);
      this._EqualsGenerator.MarkLabel(label1);
      this._EqualsGenerator.Emit(OpCodes.Stloc_0);
      System.Reflection.Emit.Label label2 = this._EqualsGenerator.DefineLabel();
      this._EqualsGenerator.Emit(OpCodes.Br_S, label2);
      this._EqualsGenerator.MarkLabel(label2);
      this._EqualsGenerator.Emit(OpCodes.Ldloc_0);
      this._EqualsGenerator.Emit(OpCodes.Ret);
      this._EqualsGenerator = (ILGenerator) null;
    }
  }
}
