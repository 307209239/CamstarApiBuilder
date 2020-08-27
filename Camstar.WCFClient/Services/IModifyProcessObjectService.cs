// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IModifyProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IModifyProcessObjectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ModifyProcessObjectMethod[] methods,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result);
  }
}
