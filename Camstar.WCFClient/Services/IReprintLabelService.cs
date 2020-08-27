// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReprintLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReprintLabelService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_LoadESigDetails_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReprintLabelMethod[] methods,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result);
  }
}
