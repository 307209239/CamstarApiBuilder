// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICompleteActivityInvestigationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICompleteActivityInvestigationService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus GetChecklistEntries(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus GetFailureDetails(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus LoadDataPoints(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus SaveFailureDetails(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Parameters parameters,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CompleteActivityInvestigationMethod[] methods,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CompleteActivityInvestigation completeActivityInvestigation,
      CompleteActivityInvestigation_Request request,
      out CompleteActivityInvestigation_Result result);
  }
}
