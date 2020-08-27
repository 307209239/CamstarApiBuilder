// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGenericTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGenericTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_LoadESigDetails_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus PostExecuteValidate(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GenericTxnMethod[] methods,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result);
  }
}
