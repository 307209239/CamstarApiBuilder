// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IApprovalSheetTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IApprovalSheetTemplateMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_LoadESigDetails_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Parameters parameters,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ApprovalSheetTemplateMaintMethod[] methods,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ApprovalSheetTemplateMaint approvalSheetTemplateMaint,
      ApprovalSheetTemplateMaint_Request request,
      out ApprovalSheetTemplateMaint_Result result);
  }
}
