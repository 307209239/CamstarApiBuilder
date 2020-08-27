// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBPStartTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBPStartTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_LoadESigDetails_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus SetWFStack(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BPStartTxnMethod[] methods,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result);
  }
}
