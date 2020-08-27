// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EMailNotificationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EMailNotificationMaintService : NotificationTargetMaintBase
  {
    public EMailNotificationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEMailNotificationMaintService), userProfile);
    }

    public ResultStatus Delete(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).Delete(this._UserProfile, eMailNotificationMaint, parameters, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(eMailNotificationMaint, EMailNotificationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((EMailNotificationMaint) null, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus Delete(EMailNotificationMaint eMailNotificationMaint)
    {
      return this.Delete(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus Delete(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.Delete(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).Freeze(this._UserProfile, eMailNotificationMaint, parameters, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(eMailNotificationMaint, EMailNotificationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((EMailNotificationMaint) null, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus Freeze(EMailNotificationMaint eMailNotificationMaint)
    {
      return this.Freeze(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus Freeze(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.Freeze(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, eMailNotificationMaint, parameters, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(eMailNotificationMaint, EMailNotificationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EMailNotificationMaint) null, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(EMailNotificationMaint eMailNotificationMaint)
    {
      return this.GetWIPMsgs(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.GetWIPMsgs(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).Load(this._UserProfile, eMailNotificationMaint, parameters, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(eMailNotificationMaint, EMailNotificationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EMailNotificationMaint) null, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus Load(EMailNotificationMaint eMailNotificationMaint)
    {
      return this.Load(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus Load(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.Load(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_LoadESigDetails_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).LoadESigDetails(this._UserProfile, eMailNotificationMaint, parameters, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(eMailNotificationMaint, EMailNotificationMaintMethods.LoadESigDetails, (EMailNotificationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EMailNotificationMaint) null, (EMailNotificationMaint_LoadESigDetails_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(EMailNotificationMaint eMailNotificationMaint)
    {
      return this.LoadESigDetails(eMailNotificationMaint, (EMailNotificationMaint_LoadESigDetails_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.LoadESigDetails(eMailNotificationMaint, (EMailNotificationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).New(this._UserProfile, eMailNotificationMaint, parameters, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(eMailNotificationMaint, EMailNotificationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((EMailNotificationMaint) null, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus New(EMailNotificationMaint eMailNotificationMaint)
    {
      return this.New(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus New(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.New(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).NewCopy(this._UserProfile, eMailNotificationMaint, parameters, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(eMailNotificationMaint, EMailNotificationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((EMailNotificationMaint) null, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus NewCopy(EMailNotificationMaint eMailNotificationMaint)
    {
      return this.NewCopy(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus NewCopy(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.NewCopy(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).SaveAs(this._UserProfile, eMailNotificationMaint, parameters, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(eMailNotificationMaint, EMailNotificationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((EMailNotificationMaint) null, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus SaveAs(EMailNotificationMaint eMailNotificationMaint)
    {
      return this.SaveAs(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus SaveAs(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.SaveAs(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Parameters parameters,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).UnFreeze(this._UserProfile, eMailNotificationMaint, parameters, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(eMailNotificationMaint, EMailNotificationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) eMailNotificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((EMailNotificationMaint) null, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus UnFreeze(EMailNotificationMaint eMailNotificationMaint)
    {
      return this.UnFreeze(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      EMailNotificationMaint eMailNotificationMaint,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.UnFreeze(eMailNotificationMaint, (EMailNotificationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject eMailNotificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((EMailNotificationMaint) eMailNotificationMaint, (EMailNotificationMaint_Parameters) parameters, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject eMailNotificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((EMailNotificationMaint) eMailNotificationMaint, (EMailNotificationMaint_Parameters) parameters, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject eMailNotificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EMailNotificationMaint) eMailNotificationMaint, (EMailNotificationMaint_LoadESigDetails_Parameters) parameters, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject eMailNotificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.New((EMailNotificationMaint) eMailNotificationMaint, (EMailNotificationMaint_Parameters) parameters, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject eMailNotificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((EMailNotificationMaint) eMailNotificationMaint, (EMailNotificationMaint_Parameters) parameters, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject eMailNotificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((EMailNotificationMaint) eMailNotificationMaint, (EMailNotificationMaint_Parameters) parameters, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject eMailNotificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((EMailNotificationMaint) eMailNotificationMaint, (EMailNotificationMaint_Parameters) parameters, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject eMailNotificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.Load((EMailNotificationMaint) eMailNotificationMaint, (EMailNotificationMaint_Parameters) parameters, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eMailNotificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EMailNotificationMaint) eMailNotificationMaint, (EMailNotificationMaint_Parameters) parameters, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      try
      {
        EMailNotificationMaintMethod[] methods = new EMailNotificationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEMailNotificationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EMailNotificationMaint cdo,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      try
      {
        return ((IEMailNotificationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((EMailNotificationMaint) cdo, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.GetEnvironment((EMailNotificationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EMailNotificationMaint cdo,
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      result = (EMailNotificationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailNotificationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EMailNotificationMaintMethod(cdo, EMailNotificationMaintMethods.ExecuteTransaction, (EMailNotificationMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailNotificationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EMailNotificationMaint) cdo, (EMailNotificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EMailNotificationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (EMailNotificationMaint_Request) null, out EMailNotificationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EMailNotificationMaint_Request request,
      out EMailNotificationMaint_Result result)
    {
      return this.ExecuteTransaction((EMailNotificationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EMailNotificationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EMailNotificationMaintMethod(cdo, EMailNotificationMaintMethods.AddDataTransaction, (EMailNotificationMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((EMailNotificationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
