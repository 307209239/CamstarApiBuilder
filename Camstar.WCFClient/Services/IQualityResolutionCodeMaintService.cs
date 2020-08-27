// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IQualityResolutionCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IQualityResolutionCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_LoadESigDetails_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      QualityResolutionCodeMaintMethod[] methods,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result);
  }
}
