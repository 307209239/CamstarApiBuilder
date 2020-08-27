// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOpenProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOpenProcessObjectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetDetails(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Parameters parameters,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OpenProcessObjectMethod[] methods,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      OpenProcessObject openProcessObject,
      OpenProcessObject_Request request,
      out OpenProcessObject_Result result);
  }
}
