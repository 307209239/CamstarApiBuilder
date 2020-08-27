// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICollectDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICollectDataService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_LoadESigDetails_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_Parameters parameters,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CollectDataMethod[] methods,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CollectData collectData,
      CollectData_Request request,
      out CollectData_Result result);
  }
}
