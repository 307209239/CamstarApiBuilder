// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICollectSamplingDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICollectSamplingDataService
  {
    [OperationContract]
    ResultStatus CollectSampling_ChangeQty(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus CollectSampling_Execution(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus CollectSampling_ProductionEvent(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_LoadESigDetails_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Parameters parameters,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CollectSamplingDataMethod[] methods,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CollectSamplingData collectSamplingData,
      CollectSamplingData_Request request,
      out CollectSamplingData_Result result);
  }
}
