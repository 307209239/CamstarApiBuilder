// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITrainingPlanMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITrainingPlanMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_LoadESigDetails_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TrainingPlanMaintMethod[] methods,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result);
  }
}
