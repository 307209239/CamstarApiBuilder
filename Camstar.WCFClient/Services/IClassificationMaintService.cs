// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IClassificationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IClassificationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_LoadESigDetails_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Parameters parameters,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ClassificationMaintMethod[] methods,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ClassificationMaint classificationMaint,
      ClassificationMaint_Request request,
      out ClassificationMaint_Result result);
  }
}
