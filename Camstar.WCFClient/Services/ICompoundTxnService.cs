// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICompoundTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICompoundTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteService(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_ExecuteService_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteSubServices(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus InitSubServiceHistories(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_LoadESigDetails_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CompoundTxnMethod[] methods,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result);
  }
}
