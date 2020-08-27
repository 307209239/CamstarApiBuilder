// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeMgtWorkflowMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeMgtWorkflowMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_LoadESigDetails_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeMgtWorkflowMaintMethod[] methods,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result);
  }
}
