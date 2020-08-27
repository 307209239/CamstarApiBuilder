// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPrintPELabelsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPrintPELabelsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_LoadESigDetails_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PrintPELabelsMethod[] methods,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result);
  }
}
