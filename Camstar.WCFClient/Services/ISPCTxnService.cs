// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISPCTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISPCTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_LoadESigDetails_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_Parameters parameters,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SPCTxnMethod[] methods,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SPCTxn sPCTxn,
      SPCTxn_Request request,
      out SPCTxn_Result result);
  }
}
