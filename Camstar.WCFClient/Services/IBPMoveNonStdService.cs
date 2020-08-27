// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBPMoveNonStdService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBPMoveNonStdService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_LoadESigDetails_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BPMoveNonStdMethod[] methods,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result);
  }
}
