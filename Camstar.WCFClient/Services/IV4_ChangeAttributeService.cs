// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IV4_ChangeAttributeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IV4_ChangeAttributeService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_LoadESigDetails_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      V4_ChangeAttributeMethod[] methods,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result);
  }
}
