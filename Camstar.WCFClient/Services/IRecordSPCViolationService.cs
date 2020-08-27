// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRecordSPCViolationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRecordSPCViolationService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_LoadESigDetails_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Parameters parameters,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RecordSPCViolationMethod[] methods,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RecordSPCViolation recordSPCViolation,
      RecordSPCViolation_Request request,
      out RecordSPCViolation_Result result);
  }
}
