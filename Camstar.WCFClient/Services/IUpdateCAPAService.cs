// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateCAPAService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateCAPAService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetDetails(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus GetCAPADetails(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus GetCrossRefDetails(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus GetDetails(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus SaveApprovalSheet(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus SubmitCAPA(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus ValidateOwner(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus ValidateServiceDetail(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_ValidateServiceDetail_Parameters parameters,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateCAPAMethod[] methods,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateCAPA updateCAPA,
      UpdateCAPA_Request request,
      out UpdateCAPA_Result result);
  }
}
