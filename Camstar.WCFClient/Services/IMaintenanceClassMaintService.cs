// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMaintenanceClassMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMaintenanceClassMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_LoadESigDetails_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Parameters parameters,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MaintenanceClassMaintMethod[] methods,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MaintenanceClassMaint maintenanceClassMaint,
      MaintenanceClassMaint_Request request,
      out MaintenanceClassMaint_Result result);
  }
}
