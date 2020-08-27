// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResourceTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResourceTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_LoadESigDetails_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_Parameters parameters,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResourceTxnMethod[] methods,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResourceTxn resourceTxn,
      ResourceTxn_Request request,
      out ResourceTxn_Result result);
  }
}
