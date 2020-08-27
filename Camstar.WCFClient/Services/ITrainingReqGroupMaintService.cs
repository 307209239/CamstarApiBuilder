// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITrainingReqGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITrainingReqGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_LoadESigDetails_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TrainingReqGroupMaintMethod[] methods,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result);
  }
}
