// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IThruputReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IThruputReqMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_LoadESigDetails_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Parameters parameters,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ThruputReqMaintMethod[] methods,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ThruputReqMaint thruputReqMaint,
      ThruputReqMaint_Request request,
      out ThruputReqMaint_Result result);
  }
}
