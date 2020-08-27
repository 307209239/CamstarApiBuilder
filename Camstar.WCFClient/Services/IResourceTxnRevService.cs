// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceTxnRevService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceTxnRevService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus GetLastTxnHistory(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_LoadESigDetails_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus SetTxnRevHistoryMainline(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_SetTxnRevHistoryMainline_Parameters parameters,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceTxnRevMethod[] methods,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceTxnRev resourceTxnRev,
      ResourceTxnRev_Request request,
      out ResourceTxnRev_Result result);
  }
}
