// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICompleteMaintenanceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICompleteMaintenanceService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus CreateServiceDetail(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_CreateServiceDetail_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus GetESigReqFromMaintReq(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_GetESigReqFromMaintReq_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_LoadESigDetails_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Parameters parameters,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CompleteMaintenanceMethod[] methods,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CompleteMaintenance completeMaintenance,
      CompleteMaintenance_Request request,
      out CompleteMaintenance_Result result);
  }
}
