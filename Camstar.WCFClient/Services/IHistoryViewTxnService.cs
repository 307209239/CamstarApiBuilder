﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IHistoryViewTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IHistoryViewTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_LoadESigDetails_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Parameters parameters,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      HistoryViewTxnMethod[] methods,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      HistoryViewTxn historyViewTxn,
      HistoryViewTxn_Request request,
      out HistoryViewTxn_Result result);
  }
}
