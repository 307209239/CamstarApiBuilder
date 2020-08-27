// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMaintenanceReqTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMaintenanceReqTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_LoadESigDetails_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Parameters parameters,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MaintenanceReqTxnMethod[] methods,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MaintenanceReqTxn maintenanceReqTxn,
      MaintenanceReqTxn_Request request,
      out MaintenanceReqTxn_Result result);
  }
}
