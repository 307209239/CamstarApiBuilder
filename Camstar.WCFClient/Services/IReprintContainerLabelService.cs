// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReprintContainerLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReprintContainerLabelService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_LoadESigDetails_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReprintContainerLabelMethod[] methods,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result);
  }
}
