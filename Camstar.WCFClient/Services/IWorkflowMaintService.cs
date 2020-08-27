// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IWorkflowMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IWorkflowMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_LoadESigDetails_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Parameters parameters,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      WorkflowMaintMethod[] methods,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      WorkflowMaint workflowMaint,
      WorkflowMaint_Request request,
      out WorkflowMaint_Result result);
  }
}
