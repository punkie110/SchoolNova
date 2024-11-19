<?php
class Bankrekening
{
 public string $rekeningnummer;
 public int $saldo;
 public string $rekeninghouder;
 function stortGeld($bedrag)
 {
    $this->saldo += $bedrag;
    return "€" . $bedrag . " is gestort op uw rekening. Uw huidige saldo op rekening " . $this->rekeningnummer . " " . $this->rekeninghouder . " is nu: €" . $this->saldo . "<br />";
 }
 function pinnen($bedrag)
 {
    $this->saldo -= $bedrag;
    return "€" . $bedrag . " is gepind. Uw huidige saldo op rekening " . $this->rekeningnummer . " " . $this->rekeninghouder . " is nu: €" . $this->saldo . "<br />";
 }
}
?>