// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAssignedMaintReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAssignedMaintReqMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus GetAssignedMaintenanceReq(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_LoadESigDetails_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_New_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus ResetResourceUOM(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_ResetResourceUOM_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus ValidateRefInfoIsUnique(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Parameters parameters,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AssignedMaintReqMaintMethod[] methods,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AssignedMaintReqMaint assignedMaintReqMaint,
      AssignedMaintReqMaint_Request request,
      out AssignedMaintReqMaint_Result result);
  }
}
