// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IHoldStatusTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IHoldStatusTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_LoadESigDetails_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Parameters parameters,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      HoldStatusTxnMethod[] methods,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      HoldStatusTxn holdStatusTxn,
      HoldStatusTxn_Request request,
      out HoldStatusTxn_Result result);
  }
}
