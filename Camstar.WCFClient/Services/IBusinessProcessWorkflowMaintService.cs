// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBusinessProcessWorkflowMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBusinessProcessWorkflowMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_LoadESigDetails_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BusinessProcessWorkflowMaintMethod[] methods,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result);
  }
}
