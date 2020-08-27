// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_LoadESigDetails_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRTxnMethod[] methods,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result);
  }
}
