// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProcessObjectTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProcessObjectTemplateMaintService
  {
    [OperationContract]
    ResultStatus AddBusinessRule(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CheckChecklist(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetOrganization(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_LoadESigDetails_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus PostLoad_Sheet(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus RefreshApprovalSheet(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ValidateEmployeeRoleCombination(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_ValidateEmployeeRoleCombination_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProcessObjectTemplateMaintMethod[] methods,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result);
  }
}
