// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICompleteRiskAssessmentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICompleteRiskAssessmentService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CompleteRiskAssessmentMethod[] methods,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result);
  }
}
