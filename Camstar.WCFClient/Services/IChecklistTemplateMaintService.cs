// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChecklistTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChecklistTemplateMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_LoadESigDetails_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Parameters parameters,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChecklistTemplateMaintMethod[] methods,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChecklistTemplateMaint checklistTemplateMaint,
      ChecklistTemplateMaint_Request request,
      out ChecklistTemplateMaint_Result result);
  }
}
