// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITrainingRecordStatusMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITrainingRecordStatusMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_LoadESigDetails_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TrainingRecordStatusMaintMethod[] methods,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result);
  }
}
