// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPrintContainerLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPrintContainerLabelService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus GetLabelInformation(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_LoadESigDetails_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PrintContainerLabelMethod[] methods,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result);
  }
}
