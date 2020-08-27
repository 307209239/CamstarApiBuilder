// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISubClassificationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISubClassificationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_LoadESigDetails_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SubClassificationMaintMethod[] methods,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result);
  }
}
