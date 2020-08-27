// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMaintenanceReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMaintenanceReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_LoadESigDetails_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Parameters parameters,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MaintenanceReasonMaintMethod[] methods,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MaintenanceReasonMaint maintenanceReasonMaint,
      MaintenanceReasonMaint_Request request,
      out MaintenanceReasonMaint_Result result);
  }
}
