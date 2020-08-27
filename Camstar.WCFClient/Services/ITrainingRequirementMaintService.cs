// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITrainingRequirementMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITrainingRequirementMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_LoadESigDetails_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Parameters parameters,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TrainingRequirementMaintMethod[] methods,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TrainingRequirementMaint trainingRequirementMaint,
      TrainingRequirementMaint_Request request,
      out TrainingRequirementMaint_Result result);
  }
}
