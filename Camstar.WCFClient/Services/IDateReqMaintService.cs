// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDateReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDateReqMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_LoadESigDetails_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Parameters parameters,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DateReqMaintMethod[] methods,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DateReqMaint dateReqMaint,
      DateReqMaint_Request request,
      out DateReqMaint_Result result);
  }
}
