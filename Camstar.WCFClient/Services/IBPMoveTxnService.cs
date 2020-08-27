// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBPMoveTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBPMoveTxnService
  {
    [OperationContract]
    ResultStatus AdditionalValidations(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_LoadESigDetails_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus ValidatePath(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus ValidatePathToStepExists(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Parameters parameters,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BPMoveTxnMethod[] methods,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BPMoveTxn bPMoveTxn,
      BPMoveTxn_Request request,
      out BPMoveTxn_Result result);
  }
}
