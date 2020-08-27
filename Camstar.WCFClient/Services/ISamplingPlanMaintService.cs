// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISamplingPlanMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISamplingPlanMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_LoadESigDetails_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Parameters parameters,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SamplingPlanMaintMethod[] methods,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SamplingPlanMaint samplingPlanMaint,
      SamplingPlanMaint_Request request,
      out SamplingPlanMaint_Result result);
  }
}
