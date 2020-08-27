// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ElectronicProcedureMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ElectronicProcedureMaintService : ProductionProcessMaintBase
  {
    public ElectronicProcedureMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IElectronicProcedureMaintService), userProfile);
    }

    public ResultStatus Delete(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).Delete(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus Delete(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.Delete(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus Delete(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.Delete(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.DeleteAllRevisions(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.DeleteAllRevisions(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).Freeze(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus Freeze(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.Freeze(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus Freeze(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.Freeze(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).GetWIPMsgs(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.GetWIPMsgs(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.GetWIPMsgs(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).Load(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus Load(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.Load(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus Load(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.Load(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_LoadESigDetails_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).LoadESigDetails(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.LoadESigDetails, (ElectronicProcedureMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_LoadESigDetails_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.LoadESigDetails(electronicProcedureMaint, (ElectronicProcedureMaint_LoadESigDetails_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.LoadESigDetails(electronicProcedureMaint, (ElectronicProcedureMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).New(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus New(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.New(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus New(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.New(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).NewCopy(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus NewCopy(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.NewCopy(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus NewCopy(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.NewCopy(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).NewRev(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus NewRev(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.NewRev(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus NewRev(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.NewRev(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).NewRevCopy(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus NewRevCopy(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.NewRevCopy(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.NewRevCopy(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).SaveAs(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus SaveAs(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.SaveAs(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus SaveAs(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.SaveAs(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).SaveAsRev(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus SaveAsRev(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.SaveAsRev(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.SaveAsRev(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Parameters parameters,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).UnFreeze(this._UserProfile, electronicProcedureMaint, parameters, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(electronicProcedureMaint, ElectronicProcedureMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) electronicProcedureMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ElectronicProcedureMaint) null, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus UnFreeze(ElectronicProcedureMaint electronicProcedureMaint)
    {
      return this.UnFreeze(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ElectronicProcedureMaint electronicProcedureMaint,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.UnFreeze(electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_LoadESigDetails_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.New((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.Load((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject electronicProcedureMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ElectronicProcedureMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ElectronicProcedureMaint) electronicProcedureMaint, (ElectronicProcedureMaint_Parameters) parameters, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      try
      {
        ElectronicProcedureMaintMethod[] methods = new ElectronicProcedureMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IElectronicProcedureMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ElectronicProcedureMaint cdo,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      try
      {
        return ((IElectronicProcedureMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ElectronicProcedureMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ElectronicProcedureMaint) cdo, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.GetEnvironment((ElectronicProcedureMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ElectronicProcedureMaint cdo,
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      result = (ElectronicProcedureMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IElectronicProcedureMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ElectronicProcedureMaintMethod(cdo, ElectronicProcedureMaintMethods.ExecuteTransaction, (ElectronicProcedureMaint_Parameters) null));
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
        ElectronicProcedureMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ElectronicProcedureMaint) cdo, (ElectronicProcedureMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ElectronicProcedureMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ElectronicProcedureMaint_Request) null, out ElectronicProcedureMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ElectronicProcedureMaint_Request request,
      out ElectronicProcedureMaint_Result result)
    {
      return this.ExecuteTransaction((ElectronicProcedureMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ElectronicProcedureMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ElectronicProcedureMaintMethod(cdo, ElectronicProcedureMaintMethods.AddDataTransaction, (ElectronicProcedureMaint_Parameters) null));
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
        return this.AddDataTransaction((ElectronicProcedureMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
