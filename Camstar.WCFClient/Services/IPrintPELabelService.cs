// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPrintPELabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPrintPELabelService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_LoadESigDetails_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PrintPELabelMethod[] methods,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result);
  }
}
