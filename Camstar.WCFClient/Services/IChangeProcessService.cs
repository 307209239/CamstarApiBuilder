// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeProcessService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeProcessService
  {
    [OperationContract]
    ResultStatus AddBusinessRule(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus GetChecklistEntries(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus GetOrganization(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus GetPrerequisites(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus LoadBusinessRules(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus LoadChecklistTemplate(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus LoadDataPoints(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus PreviewChecklist(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus ReviewDataPoints(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus SetTriageComplete(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus ValidateProcessObject(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeProcessMethod[] methods,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result);
  }
}
