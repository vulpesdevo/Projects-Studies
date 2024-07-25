
public class galanCapital extends javax.swing.JFrame {

    public galanCapital() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        porcessGalan = new javax.swing.JButton();
        clearGalan = new javax.swing.JButton();
        CAPgalan = new javax.swing.JTextField();
        MONgalan = new javax.swing.JTextField();
        TOTALgalan = new javax.swing.JTextField();
        cgalan = new javax.swing.JLabel();
        intglaan = new javax.swing.JLabel();
        mgalan = new javax.swing.JLabel();
        tgalan = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        porcessGalan.setBackground(new java.awt.Color(153, 255, 153));
        porcessGalan.setText("PROCESS");
        porcessGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                porcessGalanActionPerformed(evt);
            }
        });

        clearGalan.setBackground(new java.awt.Color(255, 153, 153));
        clearGalan.setText("CLEAR");
        clearGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                clearGalanActionPerformed(evt);
            }
        });

        cgalan.setText("Capital : ");

        intglaan.setText("Interest Rate 4.75 %");

        mgalan.setText("Monthly Interest : ");

        tgalan.setText("Total Capital w/ Int/ Year : ");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(101, 101, 101)
                        .addComponent(porcessGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(81, 81, 81)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(intglaan)
                            .addComponent(cgalan)
                            .addComponent(mgalan)
                            .addComponent(tgalan))))
                .addGap(60, 60, 60)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(TOTALgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(MONgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(CAPgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(clearGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(63, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(56, 56, 56)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(CAPgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cgalan))
                .addGap(18, 18, 18)
                .addComponent(intglaan)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 39, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(MONgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(mgalan))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(TOTALgalan, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(tgalan))
                .addGap(24, 24, 24)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(porcessGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(clearGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(50, 50, 50))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void porcessGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_porcessGalanActionPerformed
        double capGalan, monGalan, aYearGalan, tGalan;
        capGalan = Double.parseDouble(CAPgalan.getText());
        monGalan = capGalan * .0475;
        aYearGalan = monGalan * 12;
        tGalan = capGalan + aYearGalan;

        MONgalan.setText(Double.toString(monGalan));
        TOTALgalan.setText(Double.toString(tGalan));
    }//GEN-LAST:event_porcessGalanActionPerformed

    private void clearGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_clearGalanActionPerformed
        CAPgalan.setText("");
        MONgalan.setText("");
        TOTALgalan.setText("");
    }//GEN-LAST:event_clearGalanActionPerformed

    public static void main(String Galan[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new galanCapital().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextField CAPgalan;
    private javax.swing.JTextField MONgalan;
    private javax.swing.JTextField TOTALgalan;
    private javax.swing.JLabel cgalan;
    private javax.swing.JButton clearGalan;
    private javax.swing.JLabel intglaan;
    private javax.swing.JLabel mgalan;
    private javax.swing.JButton porcessGalan;
    private javax.swing.JLabel tgalan;
    // End of variables declaration//GEN-END:variables
}
