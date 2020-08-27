// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPrintLabelTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPrintLabelTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_LoadESigDetails_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PrintLabelTxnMethod[] methods,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result);
  }
}
