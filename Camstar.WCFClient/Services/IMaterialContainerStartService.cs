// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMaterialContainerStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMaterialContainerStartService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_LoadESigDetails_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus ValidateBatchStatus(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Parameters parameters,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MaterialContainerStartMethod[] methods,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MaterialContainerStart materialContainerStart,
      MaterialContainerStart_Request request,
      out MaterialContainerStart_Result result);
  }
}
