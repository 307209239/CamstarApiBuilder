// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBPMoveStdService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBPMoveStdService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_LoadESigDetails_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BPMoveStdMethod[] methods,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result);
  }
}
