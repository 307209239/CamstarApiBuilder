// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainerTxnRevService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainerTxnRevService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus GetLastTxnHistory(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_LoadESigDetails_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus SetTxnRevHistoryMainline(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_SetTxnRevHistoryMainline_Parameters parameters,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainerTxnRevMethod[] methods,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainerTxnRev containerTxnRev,
      ContainerTxnRev_Request request,
      out ContainerTxnRev_Result result);
  }
}
