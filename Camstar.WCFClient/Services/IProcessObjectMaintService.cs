// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessObjectMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProcessObjectMaintService
  {
    [OperationContract]
    ResultStatus AddBusinessRule(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus CheckChecklist(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus CheckDataPointCollection(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus CreateStructureChanges(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus GetOrganization(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus GetParentDataObjectStage(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus GetPrerequisites(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus GetStructureToChange(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_LoadESigDetails_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus LoadTemplate(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus PostLoad_Sheet(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus RefreshApprovalSheet(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus ValidateEmployeeRoleCombination(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_ValidateEmployeeRoleCombination_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus ValidatePermissions(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Parameters parameters,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProcessObjectMaintMethod[] methods,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProcessObjectMaint processObjectMaint,
      ProcessObjectMaint_Request request,
      out ProcessObjectMaint_Result result);
  }
}
