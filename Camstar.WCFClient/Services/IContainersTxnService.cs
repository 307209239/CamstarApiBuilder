// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IContainersTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IContainersTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus GetContainers(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus InitQueryParameters(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus LoadContainerDetails(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_LoadESigDetails_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus PopulateList(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_PopulateList_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus PopulateService(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_PopulateService_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus PopulateService_ESigs(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_PopulateService_ESigs_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus PopulateService_Specific(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus PopulateService_User(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ContainersTxnMethod[] methods,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result);
  }
}
