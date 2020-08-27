// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISamplingLotTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISamplingLotTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_LoadESigDetails_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Parameters parameters,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SamplingLotTxnMethod[] methods,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SamplingLotTxn samplingLotTxn,
      SamplingLotTxn_Request request,
      out SamplingLotTxn_Result result);
  }
}
