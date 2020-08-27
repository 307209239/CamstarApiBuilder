// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NotificationTargetMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NotificationTargetMaintService : NamedDataObjectMaintBase
  {
    public NotificationTargetMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (INotificationTargetMaintService), userProfile);
    }

    public ResultStatus Delete(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).Delete(this._UserProfile, notificationTargetMaint, parameters, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(notificationTargetMaint, NotificationTargetMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((NotificationTargetMaint) null, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus Delete(NotificationTargetMaint notificationTargetMaint)
    {
      return this.Delete(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus Delete(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.Delete(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).Freeze(this._UserProfile, notificationTargetMaint, parameters, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(notificationTargetMaint, NotificationTargetMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((NotificationTargetMaint) null, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus Freeze(NotificationTargetMaint notificationTargetMaint)
    {
      return this.Freeze(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus Freeze(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.Freeze(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).GetWIPMsgs(this._UserProfile, notificationTargetMaint, parameters, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(notificationTargetMaint, NotificationTargetMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NotificationTargetMaint) null, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(NotificationTargetMaint notificationTargetMaint)
    {
      return this.GetWIPMsgs(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.GetWIPMsgs(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).Load(this._UserProfile, notificationTargetMaint, parameters, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(notificationTargetMaint, NotificationTargetMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NotificationTargetMaint) null, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus Load(NotificationTargetMaint notificationTargetMaint)
    {
      return this.Load(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus Load(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.Load(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_LoadESigDetails_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).LoadESigDetails(this._UserProfile, notificationTargetMaint, parameters, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(notificationTargetMaint, NotificationTargetMaintMethods.LoadESigDetails, (NotificationTargetMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NotificationTargetMaint) null, (NotificationTargetMaint_LoadESigDetails_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus LoadESigDetails(NotificationTargetMaint notificationTargetMaint)
    {
      return this.LoadESigDetails(notificationTargetMaint, (NotificationTargetMaint_LoadESigDetails_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.LoadESigDetails(notificationTargetMaint, (NotificationTargetMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).New(this._UserProfile, notificationTargetMaint, parameters, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(notificationTargetMaint, NotificationTargetMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((NotificationTargetMaint) null, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus New(NotificationTargetMaint notificationTargetMaint)
    {
      return this.New(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus New(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.New(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).NewCopy(this._UserProfile, notificationTargetMaint, parameters, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(notificationTargetMaint, NotificationTargetMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((NotificationTargetMaint) null, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus NewCopy(NotificationTargetMaint notificationTargetMaint)
    {
      return this.NewCopy(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus NewCopy(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.NewCopy(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).SaveAs(this._UserProfile, notificationTargetMaint, parameters, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(notificationTargetMaint, NotificationTargetMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((NotificationTargetMaint) null, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus SaveAs(NotificationTargetMaint notificationTargetMaint)
    {
      return this.SaveAs(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus SaveAs(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.SaveAs(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Parameters parameters,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).UnFreeze(this._UserProfile, notificationTargetMaint, parameters, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(notificationTargetMaint, NotificationTargetMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) notificationTargetMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((NotificationTargetMaint) null, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus UnFreeze(NotificationTargetMaint notificationTargetMaint)
    {
      return this.UnFreeze(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus UnFreeze(
      NotificationTargetMaint notificationTargetMaint,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.UnFreeze(notificationTargetMaint, (NotificationTargetMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject notificationTargetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.Delete((NotificationTargetMaint) notificationTargetMaint, (NotificationTargetMaint_Parameters) parameters, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject notificationTargetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((NotificationTargetMaint) notificationTargetMaint, (NotificationTargetMaint_Parameters) parameters, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject notificationTargetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NotificationTargetMaint) notificationTargetMaint, (NotificationTargetMaint_LoadESigDetails_Parameters) parameters, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject notificationTargetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.New((NotificationTargetMaint) notificationTargetMaint, (NotificationTargetMaint_Parameters) parameters, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject notificationTargetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((NotificationTargetMaint) notificationTargetMaint, (NotificationTargetMaint_Parameters) parameters, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject notificationTargetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((NotificationTargetMaint) notificationTargetMaint, (NotificationTargetMaint_Parameters) parameters, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject notificationTargetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((NotificationTargetMaint) notificationTargetMaint, (NotificationTargetMaint_Parameters) parameters, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject notificationTargetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.Load((NotificationTargetMaint) notificationTargetMaint, (NotificationTargetMaint_Parameters) parameters, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject notificationTargetMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NotificationTargetMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NotificationTargetMaint) notificationTargetMaint, (NotificationTargetMaint_Parameters) parameters, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      try
      {
        NotificationTargetMaintMethod[] methods = new NotificationTargetMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INotificationTargetMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NotificationTargetMaint cdo,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      try
      {
        return ((INotificationTargetMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NotificationTargetMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((NotificationTargetMaint) cdo, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.GetEnvironment((NotificationTargetMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NotificationTargetMaint cdo,
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      result = (NotificationTargetMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INotificationTargetMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NotificationTargetMaintMethod(cdo, NotificationTargetMaintMethods.ExecuteTransaction, (NotificationTargetMaint_Parameters) null));
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
        NotificationTargetMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NotificationTargetMaint) cdo, (NotificationTargetMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NotificationTargetMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (NotificationTargetMaint_Request) null, out NotificationTargetMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NotificationTargetMaint_Request request,
      out NotificationTargetMaint_Result result)
    {
      return this.ExecuteTransaction((NotificationTargetMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NotificationTargetMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NotificationTargetMaintMethod(cdo, NotificationTargetMaintMethods.AddDataTransaction, (NotificationTargetMaint_Parameters) null));
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
        return this.AddDataTransaction((NotificationTargetMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
