// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITrainingRecordMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITrainingRecordMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus GetTrainingRecord(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_GetTrainingRecord_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_LoadESigDetails_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus ValidateEmployeeRoleCombination(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_ValidateEmployeeRoleCombination_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus ValidateESigRequirement(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus ValidateRefInfoIsUnique(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus ValidateTrainer(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TrainingRecordMaintMethod[] methods,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result);
  }
}
